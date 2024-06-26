﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Data.Repos;
using PetShelter.Data;
using PetShelter.Shared.Dtos;
using Moq;

namespace PetShelter.Tests
{
    public abstract class BaseRepositoryTest<TRepository, T, TModel>
            where TRepository : BaseRepository<T, TModel>
            where T : class, IBaseEntity
            where TModel : BaseModel
    {
        private Mock<PetShelterDbContext> mockContext;
        private Mock<DbSet<T>> mockDbSet;
        private Mock<IMapper> mockMapper;
        private TRepository repository;

        [SetUp]
        public void Setup()
        {
            mockContext = new Mock<PetShelterDbContext>();
            mockDbSet = new Mock<DbSet<T>>();
            mockMapper = new Mock<IMapper>();
            repository = new Mock<TRepository>(mockContext.Object, mockMapper.Object)
            { CallBase = true }.Object;
        }


        [Test]
        public void MapToModel_ValidEntity_ReturnsMappedModel()
        {
            //Arrange
            var entity = new Mock<T>();
            var model = new Mock<TModel>();
            mockMapper.Setup(m => m.Map<TModel>(entity.Object)).Returns(model.Object);

            //Act
            var result = repository.MapToModel(entity.Object);

            //Assert
            Assert.That(result, Is.EqualTo(model.Object));
        }

        [Test]
        public void MapToModel_NullEntity_ReturnsNull()
        {
            //Arrange
            T entity = null;

            //Act
            var result = repository.MapToModel(entity);

            //Assert
            Assert.That(result, Is.EqualTo(null));

        }

        [Test]
        public void MapToEntity()
        {
            //Arrange
            var model = new Mock<TModel>();

            //Act
            var result = repository.MapToEntity(model.Object);

            //Assert
            Assert.That(result, Is.EqualTo(null));
        }


        [Test]
        public void MapToEnumerableOfModel()
        {
            var entity = new Mock<IEnumerable<T>>();
            var model = new Mock<IEnumerable<TModel>>();
            mockMapper.Setup(m => m.Map<IEnumerable<TModel>>(entity.Object)).Returns(model.Object);

            //Act
            var result = repository.MapToEnumerableOfModel(entity.Object);

            //Assert
            Assert.That(result, Is.EqualTo(model.Object));
        }
    }
}
