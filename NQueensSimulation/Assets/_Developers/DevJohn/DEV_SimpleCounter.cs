//from: https://github.com/game-ci/unity-test-runner/blob/main/unity-project-with-correct-tests/Assets/Scripts/BasicCounter.cs

using System;

public class DEV_SimpleCounter
{
    public const int MaxCount = 10;

    public void Increment()
    {
        Count = Math.Min(MaxCount, Count + 1);
    }

    public int Count { get; private set; }
}
