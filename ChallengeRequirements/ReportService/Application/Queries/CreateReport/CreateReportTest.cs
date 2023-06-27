using Moq.AutoMock;
using NUnit.Framework;
using StoreService.Application.Common;
using StoreService.Domain.Store;
using StoreService.Repository;

namespace StoreService.Application.Queries.GetStoreList
{
    [TestFixture]
    public class CreateReportTest
    {
        private CreateReport _query;
        private AutoMocker _mocker;
        private Store _store;
        private List<Store> _stores;

        private const int Id = 1;
        private const string Name = "Store1";
        private const string Address = "86 Sale Street, Spring Hill, New South Wales";

        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMocker();

            _store = new Store()
            {
                Id = Id,
                Name = Name,
                Address = Address
            };

            _stores = new List<Store>()
            {
                _store
            };

            _mocker.GetMock<IStoreRepository>()
                .Setup(p => p.GetAll())
                .Returns(_stores.AsQueryable());

            _query = _mocker.CreateInstance<CreateReport>();
        }

        [Test]
        public void TestExecuteShouldReturnListOfStores()
        {
            var results = _query.Execute();

            var result = results.Single();

            Assert.That(result.Id, Is.EqualTo(Id));
            Assert.That(result.Name, Is.EqualTo(Name));
            Assert.That(result.Address, Is.EqualTo(Address));
        }
    }
}
