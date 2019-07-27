using System; using System.IO; using System.Net;
class D {
	static void Main(string[] argv) {	
		// Lastest: <2350, mm131>, <1255, beautyleg>
		// 2016-2-17 14:35 PM
		if (argv.Length >= 2) DownImg(Convert.ToInt32(argv[0]), argv[1]);
		else Console.WriteLine("Command help: downimg id site");
	}

	private static void DownImg(int id, string site) {
		for (int i = 1; i <= 100; i++) {
			string path="", url="", tgt="";
			if (site == "mm131") {
				path = @"d:\temp\mm131-" + id.ToString();
				url = "http://img1.mm131.com/pic/" + id.ToString() + "/" + i + ".jpg";
				tgt = path + @"\" + i + ".jpg";
			}
			else if(site == "beautyleg") {
				path = @"d:\temp\beautylegmm-" + id.ToString();
				url = "http://www.beautylegmm.com/photo/beautyleg/2017/" + id.ToString() + "/beautyleg-" + id.ToString() + "-00" + (i < 10 ? "0" + i.ToString() : i.ToString()) + ".jpg";
				tgt = path + @"\" + i + ".jpg";
			} else if (site == "mmjpg") {
				path = @"d:\temp\mmjgp-" + id.ToString();
				url = "http://img.mmjpg.com/2017/" + id.ToString() + "/" + i + ".jpg";
				tgt = path + @"\" + i + ".jpg";
			}
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			if (!DownloadImage(url, tgt)) break;
		} 
	}

	private static bool DownloadImage(string url, string path) {
		try
		{
			var proxy = new WebProxy("10.191.131.12", 3128) {
				Credentials = new NetworkCredential("F3216338", "samsung7863s"),
				BypassProxyOnLocal = true
			};

			var hwr = WebRequest.Create(url);
			hwr.Proxy = proxy;
			hwr.Method = "GET";
			var hwrr = (HttpWebResponse)hwr.GetResponse();

			var sr = hwrr.GetResponseStream();
			var s = File.Open(path, FileMode.Create);
			var by = new byte[1024];
			var o = 1;

			while (o > 0) {
				if (sr != null) o = sr.Read(@by, 0, 1024);
				s.Write(by, 0, o);
			}

			s.Close();
			if (sr == null) return true;
			sr.Close();

			s.Dispose();
			sr.Dispose();
			Console.WriteLine("{0} is done.", url);
			return true;
		} catch { Console.WriteLine(url + " download error."); return false; }
	}
}
