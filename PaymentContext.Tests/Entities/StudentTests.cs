using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var email = new Email("hello@marcelo.com");
            var name = new Name("Marcelo", "Silva");
            var document = new Document("242424242", EDocumentType.CPF);
            var student = new Student(name, document, email);

        }
    }
}