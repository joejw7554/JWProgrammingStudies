static long FibonacciDP(int n)
{
    if (n <= 2)
    {
        return 1;
    }

    int[] memo = new int[n + 1];

    memo[1] = 1;
    memo[2] = 1;

    for(int i=3; i<=n; i++)
    {
        memo[i] = memo[i - 1] + memo[i - 2];
    }

    return memo[n];
}

Console.WriteLine(FibonacciDP(6));