# MicroServiceExampleSelling
 Project contains ApiGateway, Consul, EventBus, Docker, Domain Driven Design, Onion Architecture
 
 
 
 

       #----------------------------------------- API Gateway -------------------------------------------

         -> Microservice mimarisiyle tasarlanan uygulamalarda clientların parçalı servislere doğrudan erişerek karmaşıklığın ve daha da önemlisi güvenlik ile ilgili 
             risklerin meydana gelmesini engellemek için bir cephe misali öncü görevi gören API yapılanmasıdır.
         -> Clientlar bu API üzerinden güvenlik ve yetkilendirme kontrollerinden geçerler ve hedefteki microservice’i API Gateway aracılığıyla tetikleyerek sonuç alırlar.
         -> API Gateway, client ile sıkı bağlı(tightly coupled) bir bağlıdır.
         
                ------  API Gateway İle Neler Yapılabilir?  ------
         
         -> Authentication ve Authorization
         
         İşlevsel sorumluluğu parça parça üstlenen servislere erişim api gateway üzerinden dolaylı yolla olacağından dolayı kimlik ve yetki doğrulama operasyonlarını sadece api gateway’de yapılandırılabilir.
         
         -> Logging
         
         Servislere yapılan istekler hakkında detaylı loglamalar gerçekleştirilebilir ve böylece hangi servis, kim tarafından, ne kadar yoğunlukta işlevsellik gösteriyor vs. gibi istatistiksel bilgiler edinilebilir.
         
         -> Response Caching
         
         API gateway üzerinden servislere gelen talepler neticesinde üretilen çıktıları cacheleyebilir ve böylece servis maliyetleri düşürülebilir.
         
         -> Routing
         
         Servislerin adreslerini farklı şekilde kapsüllenebilir ve bu kapsül üzerinden clientlar ilgili esas routelara yönlendirilebilir.

    ------ Avantajları -------

         -> Birden fazla servis tarafından üretilecek olan datayı tek bir request – response ile üretilmesini sağlar
         -> Authentication, authorization, logging, security, routing vs. gibi
         -> Clientları, uygulamanın microservislere nasıl bölündüğü hususunda düşünmekten izole eder.
         
    ----- Dezavantajları ------
         
         -> Tüm servislere erişim api gateway üzerinden olduğu için herhangi bir çöküntü yahut kesinti durumunda tüm sistem aksaklığa uğrayabilir.

    ----------------------------------------- Ocelot API Gateway -----------------------------------------

         -> Açık kaynakdır.
         -> Clientlardan gelen istekleri işlevsel açıdan uygun servislere yönlendirmekten sorumlu bir geçiş görevi gören API Gateway kütüphanesidir.
         -> Ocelot aşağıdaki gibi birçok yeteneğe sahip olan bir kütüphanedir.

               * Routing
               * Request Aggregation
               * Service Discovery with Consul & Eureka
               * Service Fabric
               * Kubernetes
               * WebSockets
               * Authentication
               * Authorisation
               * Rate Limiting
               * Caching
               * Retry policies / QoS
               * Load Balancing
               * Logging / Tracing / Correlation
               * Headers / Method / Query String / Claims Transformation
               * Custom Middleware / Delegating Handlers
               * Configuration / Administration REST API
               * Platform / Cloud Agnostic

  ----------------------- Microservice Mimarilerinde Consul ile Service Discovery -------------------------

  ----  Service Discovery -----

 -> Microservice mimarisinde servisleriniz çok dinamik bir yapıya sahiptir. 
    Mesela uygulamaya gelen isteklerin yoğunluğuna göre bazı microservislerinizi scale out etmeniz yani var olan instance sayısını artırmanız gerekebilir.
    Ya da microservice’lerinizden bazıları zamanla fail olabilir.Bunun yerine yenisi oluşturulabilir ve isteğinizi karşılayacak ip adresi zaman içerisinde değişebilir.
    Bu yüzden daha ayrıntılı bir yapıya ihtiyacımız var.Bu yapıya Service Discovery diyoruz.


---------- Consul Nedir ------------

-> Consul, kapsamlı bir service discovery aracıdır.
-> Default olarak 8500 portu üzerinden çalışır
-> Consul; service discovery, distributed key-value store, health checking özellikleriyle kendini tanımlayan high available bir DevOps ürünü olarak ifade edilebilir.

   Microservice mimarisinde servisleriniz çok dinamik bir yapıya sahiptir.
   Mesela uygulamaya gelen isteklerin yoğunluğuna göre bazı microservislerinizi scale out etmeniz yani var olan instance sayısını artırmanız gerekebilir.
   Ya da microservice’lerinizden bazıları zamanla fail olabilir.Bunun yerine yenisi oluşturulabilir ve isteğinizi karşılayacak ip adresi zaman içerisinde değişebilir.
   Bu yüzden daha ayrıntılı bir yapıya ihtiyacımız var.Bu yapıya Service Discovery diyoruz.


   Service discovery  temel olarak üç kavram üzerinde durmaktadır:
   --------------------------------------------------------------
    Discovery: Service’lerin dynamic bir ortamda cluster içerisindeki diğer service’ler ile iletişim kurabilmeleri için, birbirlerinin IP ve port bilgilerini bulmaya ihtiyaçları vardır. Discovery ise bunu sağlamaktadır.
    Health check: Health check işlemi ile sadece up olan service’lerin sistemde kalmaları, down olan’ların ise dynamic bir şekilde sistem dışı kalmaları sağlanmaktadır.
    Load balancing: Hepimizin de bildiği gibi bir hizmete gelmiş olan request’in, bu hizmeti sağlayan diğer instance’lara da dynamic olarak dağıtılmasını sağlamaktır.
   
   
   IP adresleri de dynamic olarak assign edildiği yapılarda, Bu gibi dynamic case’ler karşısında, client hangi IP adresine istek atacağını bilemeyecektir. 
   Service discovery ise bu gibi durumları nasıl otomatik olarak handle edebilirize odaklanmaktadır.

   
  ----------------------- Domain Driven Design Nedir -------------------------

  -> Karmaşık projelerin hayata geçirilmesinde sıklıkla karşılaşılan temel sorunlara çözüm bulmaya çalışan bir yaklaşımdır.

  Kavramlar;
  -----------
  * 

  
  ----------------------- Onion Architecture Nedir -------------------------


  -> Onion mimarisi, N-tier katmanlı mimarinin ileride yaşatacağı sorunları çözmeyi sunmaktadır.
  Onion ile oyunun kurallarını değiştiren şey, Domain Layer (tabiri caizse soğan’ın cücüğü) Entity’lerin Tüm Uygulamanın Merkezinde olmasıdır.
  Bu, daha yüksek esneklik ve daha az bağlantı anlamına gelir.
  Bu yaklaşımda, tüm Katmanların yalnızca Çekirdek Katmanlara bağlı olduğunu görebiliriz.

* Domain
Domain, bütün yapıda kullanılacak varlıkları (Entity) barındırır. (Örn. Ürünler, Kategoriler, Nakliyeciler vs..) bu katmana bir çekirdek katman (Core) içerisinden ulaşabilmeliyiz. Çekirdek içerisinde ise Application katmanı olduğunu görmekteyiz.

* Application
Uygulama katmanı içerisinde Domain katmanında bulunan varlıkların (Entity) sorgulanması, eklenmesi, silinmesi gibi işlemlerin sözleşmeleri (Interface) yer alır.

* Infrastructer
Altyapı katmanı olarak kullanılmaktadır. Bu katman içerisinde Veri tabanı nesneleri, dependency injection (bağımlılık ekleme) gibi nesneler barınmaktadır.

* Persistance
Altyapı katmanı’nın bir parçası olduğunu görmekteyiz. Persistance katmanı içerisinde DbContext (Veritabanı nesnesi) oluşturularak bağlı bulunduğu infrastructer katmanı ile haberleşmektedir.

* Presentation
Sunum katmanı olan bu alanda projenin hangi platformda sunulacağı barınır. Örneğin Web, Api, Console vs…

----------------------- Clean Architecture Nedir -------------------------

Hexogonal ve Onion mimarileri ile ayrıntılarında biraz farklılık gösterseler de, birbirlerine çok benziyorlar. Çünkü bu mimariler temelde aynı amaca hizmet eder yani işlerimiz katmanlara ayırmamıza.



----------------------- Mediatr Kütüphanesi -------------------------

Mediator pattern’den de kısaca bahsedecek olursak; aynı arayüz üzerinden türeyen nesneler arasındaki iletişimi, tek bir nokta üzerinden sağlamaya dayalı bir pattern’dir.İletişimi tek bir sınıf(Mediator) üzerinden
sağladığı için gevşek bağlılık sağlar.Bu konuda en çok verilen örnek uçak ve kule örneğidir.Uçakların hepsi kule ile iletişime geçer, birbirleriyle doğrudan iletişime geçmezler.Bu örnekte, Mediator nesnesi kule,
uçaklarda türeyen sınıflardır diyebiliriz.
