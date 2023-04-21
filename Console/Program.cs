var notes = new[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
var scales = new[] { "Aeolian", "Locrian", "Ionian", "Dorian", "Phrygian", "Lydian", "Mixolydian" };

Console.WriteLine($"{notes[Random.Shared.Next(notes.Length)]} {scales[Random.Shared.Next(scales.Length)]}");
Console.WriteLine($"{notes[Random.Shared.Next(notes.Length)]} {scales[Random.Shared.Next(scales.Length)]}");

Console.WriteLine($"{notes[(Random.Shared.Next(3) + 7) % 12]}m");
Console.WriteLine($"{notes[(Random.Shared.Next(3) + 7) % 12]}m");

Console.WriteLine(Random.Shared.Next(3) != 0 ? 
    $"{Random.Shared.Next(16) + 1}, {Random.Shared.Next(16) + 1}" :
    $"{Random.Shared.Next(8) + 17}, {Random.Shared.Next(8) + 17}");
Console.WriteLine($"{Random.Shared.Next(24) + 1}, {Random.Shared.Next(24) + 1}");
var tt1 = Random.Shared.Next(24) + 1;
var tt2 = Random.Shared.Next(24) + 1;
Console.WriteLine($"{tt1}, {tt1}, {tt2}, {tt2}");
