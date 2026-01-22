using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Task alarmTask= StartAlarmSync(3);

        Console.WriteLine("알람이 울리기 전까지 책을 읽습니다.");

        await alarmTask; //여기서 alramTask가 완료될때까지 기다리는것

        Console.WriteLine("이제 일어날 시간입니다");



        //await Quiz2();


    }

    private static async Task Quiz2()
    {
        Task<int> task1 = DownloadDataAsync("websiteA");
        Task<int> task2 = DownloadDataAsync("websiteB");

        Console.WriteLine("로딩바 애니메이션 출력 중");

        int size1 = await task1;
        int size2 = await task2;

        int totalSize = size1 + size2;
        Console.WriteLine($"최종 결과 {size1}+ {size2} = {totalSize}");
    }

    static async Task StartAlarmSync(int seconds)
    {
        Console.WriteLine("알람 예약 완료");

        Thread.Sleep(seconds*1000); //여기서 이제 seconds * 1000만큼 다른 스레드 일을 처리하도록 허용하는것

        Console.WriteLine("따르릉 알람이 울립니다!");
    }

    static async Task<int> DownloadDataAsync(string url)
    {
        Console.WriteLine($"데이터 다운로드 시작: {url}");

        await Task.Delay(2000);

        return 1024;
    }
}



