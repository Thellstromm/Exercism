class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;

    private int _battery = 100;

    private int _batteryDrained;

    private int _distanceDriven = 0;

    public RemoteControlCar(int speed, int batterydrained)
    {

        _speed = speed;
        _batteryDrained = batterydrained;
    }

    public bool BatteryDrained()
    {
        return _battery < _batteryDrained;

    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += _speed;
            _battery -= _batteryDrained;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while ((car.DistanceDriven()  <  _distance) && !car.BatteryDrained())
        {
            car.Drive();
        }

        if (car.DistanceDriven() < _distance)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
