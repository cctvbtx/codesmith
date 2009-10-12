﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeSmith.Data.Linq;
using NUnit.Framework;
using Tracker.Core.Data;

namespace Tracker.Tests.CacheTests
{
    [TestFixture]
    public class FromCacheTests : RoleTests
    {
        [Test]
        public void SimpleTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var query = db.Role.Where(r => r.Name == "Test Role");
                    var key = query.GetHashKey();
                    var roles = query.FromCache();
                    
                    var cache = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache);
                    Assert.AreSame(roles, cache);
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void DurationTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var query = db.Role.Where(r => r.Name == "Test Role");
                    var key = query.GetHashKey(); 
                    var roles = query.FromCache(2);
                    
                    var cache1 = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache1);
                    Assert.AreSame(roles, cache1);

                    System.Threading.Thread.Sleep(2500);

                    var cache2 = HttpRuntime.Cache.Get(key);
                    Assert.IsNull(cache2);
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void AbsoluteExpirationTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var query = db.Role.Where(r => r.Name == "Test Role");
                    var key = query.GetHashKey();
                    var roles = query.FromCache(DateTime.UtcNow.AddSeconds(2));

                    var cache1 = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache1);
                    Assert.AreSame(roles, cache1);

                    System.Threading.Thread.Sleep(2500);

                    var cache2 = HttpRuntime.Cache.Get(key);
                    Assert.IsNull(cache2);
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void SlidingExpirationTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var query = db.Role.Where(r => r.Name == "Test Role");
                    var key = query.GetHashKey();
                    var roles = query.FromCache(new TimeSpan(0, 0, 2));

                    var cache1 = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache1);
                    Assert.AreSame(roles, cache1);

                    System.Threading.Thread.Sleep(1500);
                    
                    var cache2 = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache2);
                    Assert.AreSame(roles, cache2);

                    System.Threading.Thread.Sleep(1500);

                    var cache3 = HttpRuntime.Cache.Get(key);
                    Assert.IsNotNull(cache3);
                    Assert.AreSame(roles, cache3);

                    System.Threading.Thread.Sleep(2500);

                    var cache4 = HttpRuntime.Cache.Get(key);
                    Assert.IsNull(cache4);
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void NoCacheEmptyResultTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var guid = System.Guid.NewGuid().ToString();
                    var query = db.Role.Where(r => r.Name == guid);
                    var key = query.GetHashKey();
                    var roles = query.FromCache(new CacheSettings(2, false));

                    Assert.IsNotNull(roles);
                    Assert.AreEqual(0, roles.Count());

                    var cache = HttpRuntime.Cache.Get(key);
                    Assert.IsNull(cache);
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }

        [Test]
        public void CacheEmptyResultTest()
        {
            try
            {
                using (var db = new TrackerDataContext())
                {
                    var guid = System.Guid.NewGuid().ToString();
                    var query = db.Role.Where(r => r.Name == guid);
                    var key = query.GetHashKey();
                    var roles = query.FromCache(new CacheSettings(2, true));

                    Assert.IsNotNull(roles);
                    Assert.AreEqual(0, roles.Count());

                    var cache = HttpRuntime.Cache.Get(key) as List<Role>;
                    Assert.IsNotNull(cache);
                    Assert.AreEqual(0, cache.Count());
                }
            }
            catch (AssertionException)
            {
                throw;
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
