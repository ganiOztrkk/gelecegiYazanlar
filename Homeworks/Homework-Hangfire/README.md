<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/50a64896-06d6-49d1-b039-72d3791b2be8">
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
<h2> Job Türleri Nelerdir? </h2>
</br>
<p>Hangfire, farklı görev türlerini yönetmek için çeşitli mekanizmalar sunar. İşte Hangfire'da kullanılan bazı yaygın iş türleri:</p>
<li>Fire-and-forget Jobs: Bu iş türü, görevin başlatıldıktan sonra tamamlanmasını beklemeksizin hemen geri dönmesini sağlar. Bir kere ve hemen çalışan job tipidir. İş tanımlarnı ve ardından yalnızca bir kere tetiklenir.</li>
<li>Delayed Jobs: Bu tür işler, belirli bir süre sonra yürütülmek üzere zamanlanır. Örneğin, belirli bir süre sonra bir e-posta gönderme işlemini gerçekleştirmek isteyebilirsiniz. Hangfire, bu tür işleri gecikmeli olarak planlar ve belirtilen süre sonunda yürütür. Bu job türü de yalnızca bir kere çalışır.</li>
<li>Recurring Jobs: Bu iş türü, belirli bir periyotta tekrarlanan görevlerin otomatik olarak yürütülmesini sağlar. Örneğin, her gün belirli bir saatte veritabanı yedeklemesi yapmak isteyebilirsiniz. Hangfire, bu tür işleri belirli bir zaman aralığında tekrarlanacak şekilde ayarlar ve otomatik olarak yürütür.</li>
<li>Continuations: Bu tür işler, bir görevin tamamlanmasından sonra başka bir görevin otomatik olarak başlatılmasını sağlar. Örneğin, bir dosya yükleme işlemi tamamlandığında, dosyanın işlenmesi için bir devam görevi başlatılabilir. Hangfire, bu tür işleri otomatik olarak takip eder ve devam görevlerini başlatır. </li>
<li>Batch Jobs: Bu iş türü, bir grup görevi bir araya getirerek toplu olarak yönetmenizi sağlar. Örneğin, birden çok raporun aynı anda oluşturulmasını isteyebilirsiniz. Hangfire, bu tür işleri bir parti olarak gruplar ve aynı anda yürütür.</li>
</br>
<p>Hangfire, bu iş türlerini kullanarak farklı görevleri yönetme esnekliği sağlar. İhtiyaçlarınıza ve projenize bağlı olarak, farklı iş türlerini kullanabilir ve görevleri uygun şekilde zamanlayabilirsiniz.</p>
<hr>
<h2> Hangfire Kullanmanın Faydaları? </h2>
<li>Kendi içerisinde sunmuş olduğu dashboard sayesinde, daha kolay yönetilebilir ve görünürlük sağlar.</li>
<li>Uygulamanızdan bağımsız bir şekilde çalışabilir.</li>
<li>Yapmış olduğu her bir işin bilgisini veri tabanında tuttuğu için bir bütünlük sağlar, ayrıca herhangi bir sorun olması halinde tekrar tekrar denemeyi sağlar.</li>
<hr>
<h2>.NET Core İle Hangfire Kurulumu & Kullanımına Örnek</h2>
</br>
<p>Öncelikle .NET Core API projemizi oluşturalım.</p> 
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/0ac07124-3806-47b1-8cd2-cb2c07e7449e">
<p>Ardından proje üzerinde sağ tıklayıp, “Manage Nuget Packages…” bölümüne tıklayalım ve açılan bölüm içerisinde Browse sekmesinden Hangfire’ı arattıralım. Aşağıdaki gibi bir görsel ile karşılaşacağız, “Install” butonuna tıklayarak kuralım.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/7dd0c427-d557-4eee-a39d-745ae1bb8d60">
<p>Hangfire kurulduktan sonra, proje içerisindeki “Startup.cs” dosyasına gidip aşağıdaki kodları ekleyelim.

services.AddHangfire(x =>

x.UseSqlServerStorage(“server=.; database=.; trusted_connection=true; TrustServerCertificate=True;”));

services.AddHangfireServer();</p>

<p>NOT: Yukarıda veritabanı bağlantısı için connection string belirttik. Çünkü Hangfire tüm işlemlerin bütünlüğünü sağlamak adına kendi veritabanını kullanmaktadır. Bu sayede projemizdeki herhangi bir olumsuz durumda job’larımız kaybolmamakta, kalıcılığı sağlanmaktadır.</p>
<p>NOT: Veritabanı tarafında, connection string içerisinde belirttiğimiz isimde bir database oluşturmamız gerekmektedir. Çünkü Hangfire bizim yerimize database oluşturmaz, sadece database içerisindeki tabloları oluşturur.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/bbea39fa-a243-431e-93d0-9a939ffa16cc">
<p>Ardından aynı sayfada “Configure” kısmına gelerek aşağıdaki kodu ekleyelim. Bu Hangfire’ın bize sunmuş olduğu görsel panelini kullanabilmemiz için gerekli kod olacak.

app.UseHangfireDashboard();</p>
</br>
<p>Şimdu uygulamamızı ayağa kaldırıp olan bitene bakalım. Başlangıç Url'si yerine “../hangfire” yazıp Hangfire’ın dashboard’ına bağlanabiliriz.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/87e121f3-ab72-41df-b6b5-f477c8775080">
<p>Uygulama ayağa kaldırıldıktan sonra SQL tarafını kontrol edecek olursak, oluşturduğumuz database içerisine Hangfire tablolarımız gelmiş olacak.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/909ec748-366f-4c39-a2b0-c8bf466a98fd">
<p>Yukarıdaki ekran görüntüsünde görüldüğü gibi Hangfire yapacağı işleri fiziksel olarak tutacağı tüm veritabanı yapılanmasını otomatik olarak migrate etti. Uygulama her ayağa kalktığında, Hangfire tabloları check edecek ve eğer silinen bir tablo varsa tekrardan migrate edecek ve eksik tabloyu getirecektir. Bu check işlemi uygulama her ayağa kalktığında gerçekleşir</p>
<hr>
<p>Şimdi ilk testimizi gerçekleştirmek için yeni bir Controller oluşturalım ve örnek olarak Fire-and-forget job'ı için gerekli kodları yazalım.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/93f7db22-46e4-42a1-954e-cfde1afe9c00">
<p>BackgroundJob.Enqueue(..); satırı ile kullanıcı sisteme kayıt olduktan sonra bir defaya mahsus olarak çalışacak olan bir job oluşturduk. Sonrasındaysa tetiklenecek metodu belirtiyorum. Bu sayede arka planda bir job oluşturup asenkron olarak bağımsız çalıştırmış oluruz.</p>
<p>Şimdi Postman üzerinden istekte bulunarak Job'ımızın çalışıp çalışmadığını hangfire dashboard üzerinden kontrol edelim.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/21efca9f-69f3-4722-a7cb-55594fcb1601">
<p>İstekte bulunduktan sonra Hangfire Dashboard sayfamıza dönelim ve işlemlerimizi kontrol edelim.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/f6f14811-604f-4e69-8f1d-0669a4001fe2">
<p>İşler kısmından başarılı bölümüne gelecek olursak Job'ımızın başarılı bir şekilde tetiklendiğini görüntüleyebiliriz. Ben 3 defa istekte bulunduğum için 3 işlemi de listelemiş oldu.</p>
<hr>
<p>Farklı bir örnek daha oluşturarak anlatımımı tamamlayacağım.</p>
<p> Diğer bir Job türü olan Delayed job, oluşturulduktan belirli bir süre sonra tetiklenen ve çalışan bir job çeşididir. Vereceğim örnekte tetiklendikten 10 sn sonra çalışan bir job örnek kod satırını görebilirsiniz.</p>
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/f71ab1d1-389d-4244-a6a3-d693c2f84dfb">
<img src="https://github.com/ganiOztrkk/gelecegiYazanlar/assets/127308866/a9d8ab82-ef26-45f1-8805-2b8ac991e593">

<hr>
<p>Hangfire hakkındaki yazımı burada sonlandırıyorum. Umarım sizler için faydalı olmuştur.</p>
