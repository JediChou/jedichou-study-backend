package test.uc01;

import com.thoughtworks.selenium.Selenium;
import org.openqa.selenium.ie.InternetExplorerDriver;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebDriverBackedSelenium;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.io.File;

public class login_iexplorer {

	private Selenium selenium;
	WebDriver driver;

	@Before
	public void setUp() throws Exception {
		File file = new File("D:/TestTools/Selenium/IEDriverServer.exe");
		System.setProperty("webdriver.ie.driver", file.getAbsolutePath());
		WebDriver driver = new InternetExplorerDriver();
		
		String baseUrl = "http://10.148.74.48/";
		selenium = new WebDriverBackedSelenium(driver, baseUrl);
	}

	@Test
	public void test_UICheck() throws Exception {
		selenium.open("/PortalMain/login.seam");

		// check 1: 驗證Title
		// check 2: 驗證“帳號”的label
		// check 3: 驗證“密碼”的label
		// check 4: 驗證“登入”的按鈕
		assertEquals("登入信息", selenium.getTitle());
		assertEquals("", selenium.getText("loginForm:login_graphicImage_1"));
		assertEquals("", selenium.getText("loginForm:login_graphicImage_2"));
		assertEquals("", selenium.getText("loginForm:login_graphicImage_3"));
		assertEquals("", selenium.getText("loginForm:login_commandButton_1"));

		// check 5: 驗證“帳號”的內容
		// check 6: 驗證“密碼”的內容
		// check 7: 驗證“驗證碼”的內容
		assertEquals("", selenium.getText("loginForm:username"));
		assertEquals("", selenium.getText("loginForm:password"));
		assertEquals("", selenium.getText("loginForm:confirmCode_input"));
	}

	@Test
	public void test_AllIsNull() throws Exception {
		selenium.open("/PortalMain/login.seam");
		selenium.click("id=loginForm:login_commandButton_1");

		assert (selenium.getText("msgForm:msgDialogContentTable").contains("讯息"));
		assert (selenium.getText("msgForm:msgDialogContentTable").contains("帳號为必填字段"));
	}

	@Test
	public void test_UsernameIsNull() throws Exception {
		selenium.open("/PortalMain/login.seam");
		selenium.type("id=loginForm:username", "");
		selenium.type("id=loginForm:password", "ddd");
		selenium.click("id=loginForm:login_commandButton_1");

		assert (selenium.getText("msgForm:msgDialogContentTable").contains("讯息"));
		assert (selenium.getText("msgForm:msgDialogContentTable").contains("用户名为必填字段"));
	}

	@Test
	public void test_PasswordIsNull() throws Exception {
		selenium.open("/PortalMain/login.seam");
		selenium.type("id=loginForm:username", "ddd");
		selenium.type("loginForm:password", "");
		selenium.click("id=loginForm:login_commandButton_1");

		assert (selenium.getText("msgForm:msgDialogContentTable").contains("讯息"));
		assert (selenium.getText("msgForm:msgDialogContentTable").contains("密码为必填字段"));
	}

	@Test
	public void test_UserDoesNotExist() throws Exception {
		selenium.open("/PortalMain/login.seam");
		selenium.type("id=loginForm:username", "balabalabala");
		selenium.type("loginForm:password", "testtesttest");
		selenium.click("id=loginForm:login_commandButton_1");

		assert (selenium.getText("msgForm:msgDialogContentTable").contains("讯息"));
		assert (selenium.getText("msgForm:msgDialogContentTable").contains("账号或密码错误!"));
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
