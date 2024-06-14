using Moq;
using PetShelter.Data.Repos;
using PetShelter.Services;
using PetShelter.Services.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Tests.Services
{
    public class LocationServiceTest
    {
        private readonly Mock<ILocationsRepository> _locationRepositoryMock = new Mock<ILocationsRepository>();
        private readonly ILocationsService _service;
        private LocationDto location;

        public LocationServiceTest()
        {
            _service = new LocationsService(_locationRepositoryMock.Object);
        }

        [Test]
        public async Task WhenCreateAsync_WithValidData_ThenSaveAsync()
        {
            //Arrange
            var locationDto = new LocationDto()
            {
                Id = 0,
                ShelterId = 1,
                City = "Burgas",
                Address = "Mechi vruh 5",
                Country = "Bulgaria"

            };

            //Act
            await _service.SaveAsync(locationDto);

            //Asert
            _locationRepositoryMock.Verify(x => x.SaveAsync(locationDto), Times.Once());



        }

        [Test]
        public async Task WhenSaveAsync_WithNull_ThenThrowArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () => await _service.SaveAsync(null));
            _locationRepositoryMock.Verify(x => x.SaveAsync(null), Times.Never());
        }

        [Theory]
        [TestCase(1)]
        [TestCase(22)]
        [TestCase(131)]
        public async Task WhenDeleteAsync_WithCorrectId_ThenCallDeleteAsyncInRepository(int id)
        {
            //Arrange

            //Act
            await _service.DeleteAsync(id);

            //Assert
            _locationRepositoryMock.Verify(x => x.DeleteAsync(It.Is<int>(i => i.Equals(id))), Times.Once);
        }


        [Theory]
        [TestCase(1)]
        [TestCase(22)]
        [TestCase(131)]
        public async Task WhenGetByIdAsync_WithValidBreedId_ThenReturnUser(int locationId)
        {
            //Arrange
            var locationDto = new LocationDto()
            {
                Id = 0,
                ShelterId = 1,
                City = "Burgas",
                Address = "Mechi vruh 5",
                Country = "Bulgaria"
            };
            _locationRepositoryMock.Setup(s => s.GetByIdAsync(It.Is<int>(x => x.Equals(locationId))))
                .ReturnsAsync(locationDto);
            //Act
            var userResult = await _service.GetByIdIfExistsAsync(locationId);

            //Assert
            _locationRepositoryMock.Verify(x => x.GetByIdAsync(locationId), Times.Once);
            Assert.That(userResult == locationDto);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(102021)]
        public async Task WhenGetByAsync_WithInvalidBreedId_ThenReturnDefault(int locationId)
        {
            var breedDto = (LocationDto)default;
            _locationRepositoryMock.Setup(s => s.GetByIdAsync(It.Is<int>(x => x.Equals(locationId))))
                .ReturnsAsync(breedDto);

            //Act
            var userResult = await _service.GetByIdIfExistsAsync(locationId);

            //Assert
            _locationRepositoryMock.Verify(x => x.GetByIdAsync(locationId), Times.Once);
            Assert.That(userResult == location);

        }

        [Test]
        public async Task WhenUpdateAsync_WithValidData_ThenSaveAsync()
        {
            //Arrange
            var locationDto = new LocationDto
            {
                Id = 0,
                ShelterId = 1,
                City = "Burgas",
                Address = "Mechi vruh 5",
                Country = "Bulgaria"

            };
            _locationRepositoryMock.Setup(s => s.SaveAsync(It.Is<LocationDto>(x => x.Equals(locationDto))))
               .Verifiable();
            //Act
            await _service.SaveAsync(locationDto);

            //Assert
            _locationRepositoryMock.Verify(x => x.SaveAsync(locationDto), Times.Once);
        }
    }
}
