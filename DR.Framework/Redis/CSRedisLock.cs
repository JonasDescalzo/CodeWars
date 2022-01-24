using NewLife.Caching;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DR.Framework.Redis
{
    public class CSRedisLock
    {
        /// <summary>
        /// 分布式锁
        /// </summary>
        /// <param name="key">锁key</param>
        /// <param name="lockExpirySeconds">锁自动超时时间(秒)</param>
        /// <param name="waitLockMs">等待锁时间(秒)</param>   
        /// <returns></returns>
        public static bool LockOld(string key, int lockExpirySeconds = 10, double waitLockSeconds = 0)
        {
            //间隔等待50毫秒
            int waitIntervalMs = 200;

            string lockKey = "LockForSetNX:" + key;

            var ttl = RedisHelper.Ttl(lockKey);

            if (ttl == -1)
            {
                RedisHelper.Expire(lockKey, lockExpirySeconds);
            }

            DateTime begin = DateTime.Now;
            while (true)
            {
                //循环获取取锁
                if (RedisHelper.SetNx(lockKey, 1))
                {
                    //设置锁的过期时间
                    RedisHelper.Expire(lockKey, lockExpirySeconds);
                    return true;
                }

                //不等待锁则返回
                if (waitLockSeconds == 0) break;

                //超过等待时间，则不再等待
                if ((DateTime.Now - begin).TotalSeconds >= waitLockSeconds) break;

                Thread.Sleep(waitIntervalMs);
            }
            return false;

        }

        /// <summary>
        /// 分布式锁
        /// </summary>
        /// <param name="key">锁key</param>
        /// <param name="lockExpirySeconds">锁自动超时时间(秒)</param>
        /// <param name="waitLockMs">等待锁时间(秒)</param>
        /// <returns></returns>
        public static bool Lock(string key, ICache redisCache, int lockExpirySeconds = 10, double waitLockSeconds = 0)
        {
            //间隔等待50毫秒
            int waitIntervalMs = 200;

            string lockKey = "LockForSetNX:" + key;

            var ttl = redisCache.GetExpire(lockKey);

            if (ttl.TotalMilliseconds == -1)
            {
                redisCache.AcquireLock(lockKey, lockExpirySeconds * 1000);
            }

            DateTime begin = DateTime.Now;
            while (true)
            {
                //循环获取取锁
                if (!redisCache.ContainsKey(lockKey))
                {
                    //设置锁的过期时间
                    redisCache.AcquireLock(lockKey, lockExpirySeconds * 1000);
                    return true;
                }

                //不等待锁则返回
                if (waitLockSeconds == 0) break;

                //超过等待时间，则不再等待
                if ((DateTime.Now - begin).TotalSeconds >= waitLockSeconds) break;

                Thread.Sleep(waitIntervalMs);
            }
            return false;

        }

        /// <summary>
        /// 删除锁 执行完代码以后调用释放锁
        /// </summary>
        /// <param name="key"></param>
        public static void DelLockOld(string key)
        {
            string lockKey = "LockForSetNX:" + key;
            RedisHelper.Del(lockKey);
        }

        /// <summary>
        /// 删除锁 执行完代码以后调用释放锁
        /// </summary>
        /// <param name="key"></param>
        public static void DelLock(string key, ICache redisCache)
        {
            string lockKey = "LockForSetNX:" + key;
            redisCache.Remove(lockKey);
        }
    }
}
