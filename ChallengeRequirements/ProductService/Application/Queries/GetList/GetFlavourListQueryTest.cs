using Moq.AutoMock;
using NUnit.Framework;
using ProductService.Domain.Product;
using ProductService.Repository;

namespace ProductService.Application.Queries.GetStoreList
{
    [TestFixture]
    public class GetFlavourListQueryTest
    {
        private GetFlavourListQuery _query;
        private AutoMocker _mocker;
        private Flavour _flavour;
        private List<Flavour> _flavours;

        private const int Id = 1;
        private const string Name = "Milk Tea";     

        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMocker();

            _flavour = new Flavour()
            {
                Id = Id,
                Name = Name,               
            };

            _flavours = new List<Flavour>()
            {
                _flavour
            };

            _mocker.GetMock<IFlavourRepository>()
                .Setup(p => p.GetAll())
                .Returns(_flavours.AsQueryable());

            _query = _mocker.CreateInstance<GetFlavourListQuery>();
        }

        [Test]
        public void TestExecuteShouldReturnListOfFlavours()
        {
            var results = _query.Execute();

            var result = results.Single();

            Assert.That(result.Id, Is.EqualTo(Id));
            Assert.That(result.Name, Is.EqualTo(Name));           
        }
    }
}
