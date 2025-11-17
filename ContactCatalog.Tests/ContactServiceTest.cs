using ContactCatalog.Models;
using ContactCatalog.Repositories;
using ContactCatalog.Services;
using ContactCatalog.Validators;
using Moq;
using Xunit;


namespace ContactCatalog.Tests
{
    public class ContactServiceTest
    {
        [Fact]
        public void AddContact_ShouldCallRepositorySaveContact()
        {
            //Arrange
            var mockRepo = new Mock<IContactRepository>();
            var service = new ContactService(mockRepo.Object);                        
            var contact = new Contact(1, "Sam", "sam@hobbit.com", new List<string> { "fellow" });

            //Act
            mockRepo.Object.SaveContact(contact);

            //Assert
            mockRepo.Verify(r => r.SaveContact(It.Is<Contact>(m => m.Id == 1 && m.Name == "Sam")), Times.Once);
        }
    }
}