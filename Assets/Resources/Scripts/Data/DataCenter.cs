public class DataCenter
{
    public int life;
    public int score;

    public DataCenter(DataCenter gamedata) : this(gamedata.life, gamedata.score) { }

    public DataCenter(int initLife, int initSocre)
    {
        life = initLife;
        score = initSocre;
    }
 
    public DataCenter Clone()
    {
        return new DataCenter(this);
    }
}