//1) ----------------------------------------------------------------------------------------------

private void set_mode(bool mod)
{
    label1.Enabled = mod;
    button1.Enabled = mod;
    button2.Enabled = mod;
    button3.Enabled = !mod;
    button4.Enabled = !mod;
}

//2) ----------------------------------------------------------------------------------------------

 switch (driver.Status)
{
    return m_driverStatusNames[driver.Status];
}

//3) ----------------------------------------------------------------------------------------------

uint i;
…
if (i < 10)
{
    ... 
}

//4) ----------------------------------------------------------------------------------------------

string destination = String.Join('', source);

//5) ----------------------------------------------------------------------------------------------

Bool IsNumber(string str) {
    int x = 0;
    return TryParse(str, out x);
}

//6) ----------------------------------------------------------------------------------------------

foreach (DirectoryInfo dir in dirs.GetDirectories())
{
    //create folder{16}
    stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
    stream.Read(new byte[1], 0, 1);
    foo(SubFolder, dir.name);
}
void foo(string SubFolder, string DirName)
{
    string full_dir = SubFolder + DirName;
    stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(full_dir.Replace('\\', '/')).Length), 0, 4);
}
stream.Read(new byte[1], 0, 1);
//7) ----------------------------------------------------------------------------------------------

String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//8) ----------------------------------------------------------------------------------------------

DateTime dt = DateTime.Now;
Console.WriteLine(dt.ToString("--h:m:s--");

//9) ----------------------------------------------------------------------------------------------

return (Counter % 10 != 0 && Counter != 0);

//10) ----------------------------------------------------------------------------------------------

if (Connected == 0)
{
    rez = setup();
}
fl_end = true;
//11) ----------------------------------------------------------------------------------------------

List<int> arr = new List<int>();
for (int i = 0; i < arr.Count; i++)
{
    if (arr[i] > 100)
    {
        arr.Remove(arr[i]);
    }
}
//12) ----------------------------------------------------------------------------------------------

if (form.Keys.Length >= 0) throw Exception;

//13) ----------------------------------------------------------------------------------------------

//Use the Name field
string[] nameParts = customer.Name.Split(' ');
string firstName = nameParts[0];
string lastName = nameParts[1];

//14) ----------------------------------------------------------------------------------------------

sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);

//15) ----------------------------------------------------------------------------------------------

public string generateEMail()
{
    string res = PersonName.Replace(' ', '.');
    res += "@domain.ua";
    return res;
}

//16) ----------------------------------------------------------------------------------------------

sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);

//17) ----------------------------------------------------------------------------------------------

string GetTextDiv2(string text)
 {
    int mid = text.Length / 2;
    int r = text.IndexOf(" ", mid);
    if (r < 0) r = 5000;
    int l = text.IndexOf(" ", 0, mid);
    if (l < 0) l = 5000;
    mid = l <= r ? l : r;
    if (mid == 5000) return "&nbsp" + text;
    return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" + text.Substring(mid, text.Length - mid);
}

//18) ----------------------------------------------------------------------------------------------

private static readonly char SPECIFIER = '$';
private static readonly char DELIMITER = ':';
private static readonly char[] DELIMITER_ARRAY = { DELIMITER };

//19) ----------------------------------------------------------------------------------------------

string email = Config.GetSetting("AdminNotifications_EmailAddress");
string mailTo = (email.isEmpty()))? Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString(): email;

//20) ----------------------------------------------------------------------------------------------

public bool CheckPath(string path)
{
    int n;
    n = 0;
    String[] dirs = GetDirectories(path);
    //Проверяем наличие нужных папок;
    if (dirs.Contains("SCLAD"))
    {
        n += 1;
        String[] sclad = GetFiles(path + "\\SCLAD");
        if (sclad.Contains("mdoc.dbf")) n += 1;
        if (sclad.Contains("mdoc.fpt")) n += 1;
        if (sclad.Contains("mdocm.dbf")) n += 1;
        if (sclad.Contains("mgrup.dbf")) n += 1;
        if (sclad.Contains("mlabel.dbf")) n += 1;
        if (sclad.Contains("mlabel.fpt")) n += 1;
    }
    if (dirs.Contains("REAL"))
    {
        n += 1;
        String[] REAL = GetFiles(path + "\\REAL");
        if (REAL.Contains("rbookm.dbf")) n += 1;
        if (REAL.Contains("rbook.dbf")) n += 1;
        if (REAL.Contains("rbook.fpt")) n += 1;
    }
    if (dirs.Contains("DOSTAVKA"))
    {
        n += 1;
        String[] DOSTAVKA = GetFiles(path + "\\DOSTAVKA");
        if (DOSTAVKA.Contains("avt.dbf")) n += 1;
        if (DOSTAVKA.Contains("avtm.dbf")) n += 1;
        if (DOSTAVKA.Contains("avtm.fpt")) n += 1;
        if (DOSTAVKA.Contains("cargo.dbf")) n += 1;
        if (DOSTAVKA.Contains("cargom.dbf")) n += 1;
        if (DOSTAVKA.Contains("rcargo.dbf))"n += 1;
        if (DOSTAVKA.Contains("zamena.dbf")) n += 1;
        if (DOSTAVKA.Contains("rbookm.dbf))"n += 1;
        if (DOSTAVKA.Contains("rbook.dbf))"n += 1;
        if (DOSTAVKA.Contains("rbook.fpt))"n += 1;
    }
    return n == 20;
}

//21) ----------------------------------------------------------------------------------------------

txtContacts.Text = ";" + String.Join('', conctacts);
//22) ----------------------------------------------------------------------------------------------

Game1.clou = !Game1.clou;