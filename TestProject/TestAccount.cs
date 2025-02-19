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

    //[Test]
    //public void Login_ValidCredentials_ReturnsTrue()
    //{
    //    bool result = _dal.Login("test@example.com", "password");

    //    Assert.That(result, Is.True);
    //}

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
    public void Login_ValidCredentials_ReturnsTrue()
    {
        bool result = _dal.Login("loginus@gmail", "1234");
        Assert.That(result, Is.True);
    }
    [Test]
    [TestCase("", "aaa")]
    [TestCase("aaa", "")]
    [TestCase("loginus@gmail", "wrongpass")]
    [TestCase("wrongmail", "1234")]
    public void Login_WithSomeThing_ReturnsFalse(string username, string password)
    {
        bool result = _dal.Login(username, password);
        Assert.IsFalse(result);
    }
    [Test]
    public void GetRole_AdminEmail_ReturnsAdmin()
    {
        string role = _dal.ChucVuNguoiDangNhap("chungbao@gmail");
        Assert.That(role, Is.EqualTo("Quản Trị"));
    }

    [Test]
    public void GetRole_EmployeeEmail_ReturnsEmployee()
    {
        string role = _dal.ChucVuNguoiDangNhap("phucdien@gmail");
        Assert.That(role, Is.EqualTo("Nhân Viên"));
    }
    [Test]
    public void SendMail_ValidEmail_ReturnsTrue()
    {
        bool result = _dal.SendMail("something@example.com");
        Assert.That(result, Is.True);
    }

    [Test]
    public void SendMail_InvalidEmail_ReturnsFalse()
    {
        bool result = _dal.SendMail("invalidemail");
        Assert.That(result, Is.False);
    }
}
