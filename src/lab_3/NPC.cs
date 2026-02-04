namespace lab_3;

/// <summary>
/// Represents Non-player character model. 
/// </summary>
public class NPC
{
    ///<summary>Gets or sets of params</summary>
    public string Name { get; set; }
    public string Surename { get; set; }
    public string Hobby { get; set; }
    public int XP { get; set; }
    public int Age { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NPC"/> class with specified attributes.
    /// </summary>
    /// <param name="name">The NPC's first name.</param>
    /// <param name="surname">The NPC's surname.</param>
    /// <param name="hobby">The NPC's hobby.</param>
    /// <param name="xp">The amount of experience points.</param>
    /// <param name="age">The NPC's age in years.</param>
    public NPC(string name, string surename, string hobby, int xp, int age)
    {
        Name = name;
        Surename = surename;
        Hobby = hobby;
        XP = xp;
        Age = age;
    }

    /// <summary>
    /// Determines whether the specified NPC object is identical to the current object.
    /// </summary>
    /// <param name="other">The NPC object to compare with the current object.</param>
    /// <returns>True if all properties are identical; otherwise, false.</returns>
    public bool Equals(NPC guy)
    {
        if (guy == null) return false;
        return Name == guy.Name &&
               Surename == guy.Surename &&
               Hobby == guy.Hobby &&
               XP == guy.XP &&
               Age == guy.Age;
    }

    /// <summary>
    /// Returns a string that represents the current NPC object.
    /// </summary>
    /// <returns>A formatted string containing NPC details.</returns>
    public override string ToString()
    {
        return $"{Name,-6} | Surename: {Surename,-10} | Hobby: {Hobby,-11} | XP: {XP,-7} | Age: {Age}";
    }

}