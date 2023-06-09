<h2> Hangfire Nedir? </h2>
</br>
<p><b>Hangfire</b>, .NET tabanlı bir açık kaynak arka plan görev(Background Job) yürütme kütüphanesidir. Hangfire, arkada asenkron olarak çalışır, yani kullanıcıyı bekletmez. Bu kütüphane, gecikmeli veya tekrarlanan görevleri işlemek için kullanılan bir çözüm sunar.</p>

<p>Hangfire mutlaka bir depolama alanına, yani DB’ye ihtiyaç duyar ve depolama alanı olarak bir çok veritabanını desteklemektedir.(SQL Server, SQL Server + MSMQ, Redis ...)</p>

<h3>Background Jobs Nedir?</h3>
<p>Arka plan görevleri olarak nitelendirilen Background Jobs aslında zamanlanmış işlerin ta kendisidir. Bazen uygulamalarımızın ana thread dışında bir task işlemesi veya belli aralıklarla bazı işlemlerin gerçekleştirilmesi gerekebilmektedir. İşte bu tarz ihtiyaçlara binaen gerçekleştirilen zamanlanmış görevleri background jobs olarak isimlendirmekteyiz.</p>

<hr>
<h2> Hangfire Ne Amaçla Kullanılır? </h2>
</br>
<p>Hangfire'ın temel amacı, işlerin belirli bir süre boyunca çalışması için arka plana yerleştirilmesini sağlamaktır. Hangfire, gecikmeli veya zamanlanmış görevleri işlemek için bir sıra mekanizması kullanır ve bu görevleri belirli bir zamanda veya belirli bir süre sonra yürütmek için zamanlanabilir. Uzun süreli işlemleri, zaman ayarlı görevleri, e-posta gönderme işlemlerini, rapor oluşturma işlemlerini ve diğer otomatik görevleri kolayca yönetmek için kullanılabilir.</p>

<p>Ayrıca, tekrarlanan görevleri yönetmek için de Hangfire kullanılabilir. Örneğin, periyodik olarak veritabanı yedeklemesi yapmak veya belirli bir zaman aralığında veri analizi işlemlerini gerçekleştirmek isteyebilirsiniz. Hangfire, bu tekrarlanan görevleri kolayca zamanlayabilir ve yönetebilir, böylece bunları manuel olarak başlatmanız veya yönetmeniz gerekmez.</p>

<p>Hangfire'ın var olmasının temel nedeni, web uygulamalarının performansını artırmak ve kullanıcı deneyimini iyileştirmektir. İşlerin arka planda yürütülmesi, web uygulamasının daha hızlı ve duyarlı olmasını sağlar. Ayrıca, uzun süren işlemlerin başarılı bir şekilde tamamlanmasını sağlar ve kullanıcıların beklemek zorunda kalmadan diğer görevleri gerçekleştirmesine olanak tanır.</p>
<hr>
