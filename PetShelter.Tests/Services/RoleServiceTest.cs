using Moq;
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
    public class RoleServiceTest
    {
        private readonly Mock<IRolesRepository> _roleRepositoryMock = new Mock<IRolesRepository>();
        private readonly IRoleService _service;
        private RoleDto role;

        public RoleServiceTest()
        {
            _service = new RolesService(_roleRepositoryMock.Object);
        }

        [Test]
        public async Task WhenCreateAsync_WithValidData_ThenSaveAsync()
        {
            //Arrange
            var roleDto = new RoleDto()
            {

                Name = "Vancho",


            };

            //Act
            await _service.SaveAsync(roleDto);

            //Asert
            _roleRepositoryMock.Verify(x => x.SaveAsync(roleDto), Times.Once());



        }

        [Test]
        public async Task WhenSaveAsync_WithNull_ThenThrowArgumentNullException()
        {
            Assert.ThrowsAsync<ArgumentNullException>(async () => await _service.SaveAsync(null));
            _roleRepositoryMock.Verify(x => x.SaveAsync(null), Times.Never());
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
            _roleRepositoryMock.Verify(x => x.DeleteAsync(It.Is<int>(i => i.Equals(id))), Times.Once);
        }


        [Theory]
        [TestCase(1)]
        [TestCase(22)]
        [TestCase(131)]
        public async Task WhenGetByIdAsync_WithValidBreedId_ThenReturnUser(int roleId)
        {
            //Arrange
            var roleDto = new RoleDto()
            {

                Name = "Vancho",
            };
            _roleRepositoryMock.Setup(s => s.GetByIdAsync(It.Is<int>(x => x.Equals(roleId))))
                .ReturnsAsync(roleDto);
            //Act
            var userResult = await _service.GetByIdIfExistsAsync(roleId);

            //Assert
            _roleRepositoryMock.Verify(x => x.GetByIdAsync(roleId), Times.Once);
            Assert.That(userResult == roleDto);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(102021)]
        public async Task WhenGetByAsync_WithInvalidBreedId_ThenReturnDefault(int roleId)
        {
            var roleDto = (RoleDto)default;
            _roleRepositoryMock.Setup(s => s.GetByIdAsync(It.Is<int>(x => x.Equals(roleId))))
                .ReturnsAsync(roleDto);

            //Act
            var userResult = await _service.GetByIdIfExistsAsync(roleId);

            //Assert
            _roleRepositoryMock.Verify(x => x.GetByIdAsync(roleId), Times.Once);
            Assert.That(userResult == role);

        }

        [Test]
        public async Task WhenUpdateAsync_WithValidData_ThenSaveAsync()
        {
            //Arrange
            var roleDto = new RoleDto
            {
                Name = "Vancho",

            };
            _roleRepositoryMock.Setup(s => s.SaveAsync(It.Is<RoleDto>(x => x.Equals(roleDto))))
               .Verifiable();
            //Act
            await _service.SaveAsync(roleDto);

            //Assert
            _roleRepositoryMock.Verify(x => x.SaveAsync(roleDto), Times.Once);
        }

    }
}
