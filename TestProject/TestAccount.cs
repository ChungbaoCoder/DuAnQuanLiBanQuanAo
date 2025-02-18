using QuanLiShopQuanAo.DAL;
using QuanLiShopQuanAo.DataBaseConnection;

namespace TestProject;

[TestFixture]
public class DAL_AccountTests
{
    private DAL_Account _dal;
    private string _testConnectionString;

    [SetUp]
    public void Setup()
    {
        _testConnectionString = DBConnection.ConnectionString;
        _dal = new DAL_Account();
    }

    [Test]
    public void Login_ValidCredentials_ReturnsTrue()
    {
        bool result = _dal.Login("test@example.com", "password");

        Assert.That(result, Is.True);
    }

    [Test]
    public void Login_InvalidCredentials_ReturnsFalse()
    {
        bool result = _dal.Login("test@example.com", "wrongpassword");

        Assert.That(result, Is.False);
    }

    [Test]
    public void ChangePassword_ValidCredentials_ReturnsTrue()
    {
        // Note: The ChangePassword method currently does not validate email and password
        // To make the test valuable, you must refactor your method and add that validation
        bool result = _dal.ChangePassword("test@example.com", "password", "newpassword", "newpassword");

        Assert.That(result, Is.True);

        //Verify successful password change by trying to log in with new password
        Assert.That(_dal.Login("test@example.com", "newpassword"), Is.True);
        Assert.That(_dal.Login("test@example.com", "password"), Is.False);//Verify that previous password no longer works
    }

    [Test]
    public void ChangePassword_InvalidOldPassword_ReturnsFalse()
    {
        // Note: The ChangePassword method currently does not validate email and password
        // To make the test valuable, you must refactor your method and add that validation
        bool result = _dal.ChangePassword("test@example.com", "wrongpassword", "newpassword", "newpassword");

        //Password should fail to change
        Assert.That(result, Is.False);
    }
}
