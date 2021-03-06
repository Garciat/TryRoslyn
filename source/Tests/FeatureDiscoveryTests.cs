﻿using TryRoslyn.Server.Compilation.Internal;
using Xunit;

namespace TryRoslyn.Tests {
    public class FeatureDiscoveryTests {
        [Fact]
        public void CSharpDiscoverAll_ReturnsExpectedFeature() {
            Assert.Contains("IOperation", new CSharpFeatureDiscovery().SlowDiscoverAll());
        }

        [Fact]
        public void VBNetDiscoverAll_ReturnsExpectedFeature() {
            Assert.Contains("IOperation", new VisualBasicFeatureDiscovery().SlowDiscoverAll());
        }
    }
}
