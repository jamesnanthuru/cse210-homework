public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public string _startYear = "";
    public string _endYear = "";

    // Displays the job information in the format:
    // Job Title (Company) StartYear-EndYear
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}