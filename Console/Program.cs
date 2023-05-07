var notes = new[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
var scales = new[] { "Aeolian", "Locrian", "Ionian", "Dorian", "Phrygian", "Lydian", "Mixolydian" };

var random = Random.Shared;
Console.WriteLine($"{notes[random.Next(notes.Length)]} {scales[random.Next(scales.Length)]}");

Console.WriteLine($"{notes[(random.Next(8) + 4) % 12]}{(random.Next(4) == 0 ? "" : "m")}");
Console.WriteLine($"{notes[(random.Next(8) + 4) % 12]}{(random.Next(4) == 0 ? "" : "m")}");
Console.WriteLine($"{notes[(random.Next(8) + 4) % 12]}{(random.Next(4) == 0 ? "" : "m")}");

Console.WriteLine(random.Next(3) != 0 ? 
    $"{random.Next(16) + 1}, {random.Next(16) + 1}" :
    $"{random.Next(8) + 17}, {random.Next(8) + 17}");
Console.WriteLine($"{random.Next(24) + 1}, {random.Next(24) + 1}");
var tt1 = random.Next(24) + 1;
var tt2 = random.Next(24) + 1;
Console.WriteLine($"{tt1}, {tt1}, {tt2}, {tt2}");
