namespace TreehouseDefense
{
  class Invader
  {
    // private MapLocation _location;

    // public MapLocation GetLocation() //getter
    // {
    //   return _location
    // }
    //
    // public void SetLocation(MapLocation value) //setter
    // {
    //   _location = value;
    // }

    // public MapLocation Location
    // {
    //   get //getter
    //   {
    //     return _location;
    //   }
    //   private set //setter
    //   {
    //     _location = value;
    //   }
    // }

    private readonly Path _path;
    private int _pathStep = 0;

    public MapLocation Location => _path.GetLocationAt(_pathStep);

    public int Health { get; private set; } = 2;

    public bool HasScored { get { return _pathStep >= _path.Length;}}

    public bool IsNeuttrailzed => Health <= 0;

    public bool IsActive => !(IsNeuttrailzed || HasScored);

    public Invader(Path path)
    {
      _path = path;
    }

    public void Move() => _pathStep += 1;

    public void DecreaseHealth(int factor)
    {
      Health -= factor;
    }


  }
}
