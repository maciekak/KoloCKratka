public class Subject{
    private List<Observer> list;
    void RegisterObserver(Observer observer){
        list.Add(observer);
    }

    void NotifyObservers(){
        foreach(var observer in list){
            observer.Update();
        }
    }
}

public interface Observer{
    void Update();
}

public class ConcrateObserver : Observer{
    public Update(){
        Console.WriteLine("Updatowanie widoku");
    }
}

public class Main{
    event EventHandler<EventArgs> WeatherChanged;

    public static void main(string[] args){
        var observer = new ConcrateObserver();
        var weatherStation = new Subject();

        weatherStation.RegisterObserver(observer);
        WeatherChanged += observer.Update();
    }
}
