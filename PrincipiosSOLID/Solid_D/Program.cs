// See https://aka.ms/new-console-template for more information
using System.Text.Json;

//string origin = @"C:\Users\stalk\Desktop\post.json";
string dbPath = @"C:\Users\stalk\Desktop\db.json";
string origin = @"https://jsonplaceholder.typicode.com/todos/";

IInfo info = new InfoByRequest(origin);

Monitor monitor = new Monitor(info);
await monitor.Show();

FileDb fileDb = new FileDb(dbPath, info);
await fileDb.Save();

// Clase de alto nivel
public class Monitor
{
    //private string _origin;
    // Inyeccion
    private IInfo _info;
    public Monitor(IInfo info)
    {
        //_origin = origin;
        _info = info;
    }
    public async Task Show()
    {
        //InfoByFile info = new InfoByFile(_origin);
        //InfoByRequest info = new InfoByRequest(_origin);
        var posts = await _info.Get();
        foreach (var i in posts)
            Console.WriteLine(i.title);
    }
}
public class FileDb
{
    private string _path;
    //private string _origin;
    private IInfo _info;
    public FileDb(string path, IInfo info)
    {
        _path = path;
        //_origin = origin;
        _info = info;
    }
    public async Task Save()
    {
        //InfoByFile info = new InfoByFile(_origin);
        //InfoByRequest info = new InfoByRequest(_origin);

        var posts = await _info.Get();
        string json = JsonSerializer.Serialize(posts);
        await File.WriteAllTextAsync(_path,json);
    }
}
// Metodo que va a un servicio
public class InfoByRequest:IInfo
{
    private string _url;

    public InfoByRequest(string url)
    {
        _url = url;
    }
    public async Task<IEnumerable<Post>> Get()
    {
        HttpClient client = new HttpClient();
        var resp = await client.GetAsync(_url);
        var stream = await resp.Content.ReadAsStreamAsync();
        List<Post> posts = await JsonSerializer.DeserializeAsync<List<Post>>(stream);
        return posts;
    }
}
// Clase de bajo nivel
public class InfoByFile:IInfo
{
    private string _path;
    public InfoByFile(string path)
    {
        _path = path;
    }
    public async Task<IEnumerable<Post>> Get()
    {
        var stream = new FileStream(_path, FileMode.Open, FileAccess.Read);
        IEnumerable<Post> psots = await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(stream);
        return psots;
    }
}
public interface IInfo
{
    public Task<IEnumerable<Post>> Get();
}
public class Post
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
}