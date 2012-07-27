﻿using System;
using Glimpse.Core2.Extensibility;
using Moq;
using Xunit;

namespace Glimpse.Test.Core2.Resource
{
    public class ConfigurationShould
    {
        [Fact]
        public void ReturnProperName()
        {
            var name = "glimpse-config";

            var resource = new Glimpse.Core2.Resource.Configuration();

            Assert.Equal(name, Glimpse.Core2.Resource.Configuration.InternalName);
            Assert.Equal(name, resource.Name);
        }

        [Fact]
        public void ReturnNoParameterKeys()
        {
            var resource = new Glimpse.Core2.Resource.Configuration();
            Assert.Empty(resource.ParameterKeys);
        }

        [Fact]
        public void Execute()
        {
            var contextMock = new Mock<IResourceContext>();

            var resource = new Glimpse.Core2.Resource.Configuration();


            Assert.Throws<NotImplementedException>(() => resource.Execute(contextMock.Object));
        }
    }
}