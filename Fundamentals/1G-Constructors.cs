class FiFa
{
    public string host;
    public DateTime year;
    public string winner;
    public string[] teams;

    //default constructor
    public FiFa()
    {

    }
    //Parameterized constructor
    public FiFa(string h, DateTime y, string w, string[] tms)
    {
        host = h;
        year = y;
        winner = w;
        teams = tms;
    }
}