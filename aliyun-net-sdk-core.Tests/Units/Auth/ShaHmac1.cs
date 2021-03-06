﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Aliyun.Acs.Core.Auth;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class ShaHmac1Test
    {
        private ShaHmac1 instance;

        public ShaHmac1 getInstance()
        {
            if (null == instance)
            {
                instance = new ShaHmac1();
            }

            return instance;
        }

        [Fact]
        public void GetSignerName()
        {
            var signer = getInstance().SignerName;
            Assert.Equal("HMAC-SHA1", signer);
        }

        [Fact]
        public void GetSignerVersion()
        {
            var signerVersion = getInstance().SignerVersion;
            Assert.Equal("1.0", signerVersion);
        }

        [Fact]
        public void SignString()
        {
            var str = getInstance().SignString("foo", "secret");
            Assert.Equal("m67ZG+f1i1fIJLYNp8smKy7K+9I=", str);
        }
    }
}
