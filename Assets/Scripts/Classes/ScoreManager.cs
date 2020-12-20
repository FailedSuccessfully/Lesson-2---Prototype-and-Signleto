public class ScoreManager
{

    private static ScoreManager _instance;
    private int _score = 0;

    public static ScoreManager GetInstance(){
        if (_instance == null)
            _instance = new ScoreManager();
        return _instance;
    }
    // Start is called before the first frame update

    public int GetScore(){
        return GetInstance()._score;
    }

    public void UpdateScore(int add) {
        _score += add;
    }
}