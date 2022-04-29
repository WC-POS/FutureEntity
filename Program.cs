
//string url = "localhost:8000/api/";

//HttpClient client = new HttpClient();
//HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Put,url);
//HttpResponseMessage res =  await client.SendAsync(message);
Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
var repository = new FutureEntity.Entities.FutureDBContext();
foreach(var entry in repository.Sales.ToList()){
    Console.WriteLine(entry.CheckNumber);
}
//client.Dispose();







