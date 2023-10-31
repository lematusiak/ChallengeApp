// 2023.10.28 Ruszamy po buksowaniu  - METODY

// public void to metoda, która nie zwraca żadnej wartości
// Używamy tej metody, gdy nie oczekujemy żadnego konkretnego wyniku tych działań


User user1 = new User("Adam", "123");
User user2 = new User("Zuza", "123");
User user3 = new User("Pola", "123");
User user4 = new User("Olek", "123");

user1.AddScore(5);
user1.score(5555533);



class User
{
    private int score = 0; 
    public User (string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public void AddScore(int number)
    {
    this.score = this.score + number;
 // this.score += number;            // to jest ten sam zapis, co linia powyżej
    }

} 