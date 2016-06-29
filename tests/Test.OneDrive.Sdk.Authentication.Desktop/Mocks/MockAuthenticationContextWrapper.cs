﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Test.OneDrive.Sdk.Authentication.Desktop.Mocks
{
    using Microsoft.OneDrive.Sdk.Authentication;
    using Moq;

    public class MockAuthenticationContextWrapper : Mock<IAuthenticationContextWrapper>
    {
        public MockAuthenticationContextWrapper()
            : base(MockBehavior.Strict)
        {
            this.SetupGet(wrapper => wrapper.TokenCache).Returns(new MockTokenCache().Object);
        }
    }
}
