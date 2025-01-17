global using ErrorAction = System.Action<CS8_MessageAPI.Models.ErrorRecord>;
using CS8_MessageAPI.Services;
// this is my PostMan analog
var apiService = new ApiService();

var loginSuccess = true;

await apiService.Login("jiwon.lee@winsor.edu", "%@&EWJhdh714",
    err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    });
    
if(!loginSuccess)
    return;
var assessments = await apiService.SendAsync<AssessmentCalendar[]>(HttpMethod.Get, "api/assessments-calendar", err =>
    {
        Console.WriteLine(err);
        loginSuccess = false;
    }
);

foreach (var assessment in assessments ?? [])
{
    Console.WriteLine(assessment);
}

/*
Console.WriteLine($"jwt: {apiService.AuthorizedUser?.jwt}");

var b64String = Convert.FromBase64String(apiService.AuthorizedUser?.jwt ?? "");

Console.WriteLine(b64String);
*/