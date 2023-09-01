using Snappier;

void UseSnappier() {
    byte[] Data = {0, 1, 2, 5, 3, 7, 5, 4, 4, 5, 7, 4};
    byte[] buffer = new byte[Snappy.GetMaxCompressedLength(Data.Count())];
    int compressedLength = Snappy.Compress(Data, buffer);
    Span<byte> compressed = buffer.AsSpan(0, compressedLength);
}

UseSnappier();

var counter = 0;
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;

while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}
