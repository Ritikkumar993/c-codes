class RemoteControlCar
{
    int _battery=100;
    int _distanceDriven=0;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
        
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if(_battery==0){
            return "Battery empty";
        }
        return $"Battery at {_battery}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if(_battery<=0) return;
        _battery-=1;
        _distanceDriven+=20;
        return;
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
