﻿using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftwarePioniere.ReadModel.Tests;
using Xunit;
using Xunit.Abstractions;

namespace SoftwarePioniere.ReadModel.Services.AzureCosmosDb.Tests
{
    [Collection("AzureCosmosDbCollection")]
    public class AzureCosmosdbEntityStoreTests  : EntityStoreTestsBase
    {
        public AzureCosmosdbEntityStoreTests(ITestOutputHelper output) : base(output)
        {
            ServiceCollection
                .AddOptions()
                .AddAzureCosmosDbEntityStore(options => Configurator.Instance.ConfigurationRoot.Bind("AzureCosmosDb", options));
        }

        [Fact]
        public override Task CanInsertAndDeleteItem()
        {
            return base.CanInsertAndDeleteItem();
        }

        [Fact]
        public override Task CanInsertAndUpdateItem()
        {
            return base.CanInsertAndUpdateItem();
        }

        [Fact]
        public override Task CanInsertItem()
        {
            return base.CanInsertItem();
        }

        [Fact]
        public override void DeleteThrowsErrorWithKeyNullOrEmpty()
        {
            base.DeleteThrowsErrorWithKeyNullOrEmpty();
        }

        [Fact]
        public override void LoadItemThrowsErrorWithKeyNullOrEmpty()
        {
            base.LoadItemThrowsErrorWithKeyNullOrEmpty();
        }

        [Fact]
        public override Task LoadItemsWithPagingWorks()
        {
            return base.LoadItemsWithPagingWorks();
        }

        [Fact]
        public override Task LoadItemsWithWhereWorks()
        {
            return base.LoadItemsWithWhereWorks();
        }

        [Fact]
        public override Task SaveAndLoadItemPropertiesEquals()
        {
            return base.SaveAndLoadItemPropertiesEquals();
        }

        [Fact]
        public override Task SaveAndLoadItemsContainsAll()
        {
            return base.SaveAndLoadItemsContainsAll();
        }

        [Fact]
        public override Task SaveAndUpdateItemPropertiesEquals()
        {
            return base.SaveAndUpdateItemPropertiesEquals();
        }

        [Fact]
        public override void SaveThrowsErrorWithItemNull()
        {
            base.SaveThrowsErrorWithItemNull();
        }

        [Fact]
        public override Task CanInsertManyItems()
        {
            return base.CanInsertManyItems();
        }
    }
}