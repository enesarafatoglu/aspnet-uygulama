namespace BtkAkademi.Models
{ // static yaptık böylelikle farklı tarayıcılardan giren kullanıcılar da 
  // diğer kayıt yaptıran kişileri görebiliyor
    public static class Repository
    {
        private static List<Candidate> applications = new(); //bu liste sadece sınıf içinde kullanılacağı için private yaptık

        //geriye listeyi döndürmemiz gereken durumlar olabilir örneğin kullanıcı kimlerin başvurduğunu görmek istyebilir böyle bir talep gelebilir     readonly
        public static IEnumerable<Candidate> Applications => applications;
        //IEnumerable -> numara edilebilir, her defasında bir örnek dönebilir

        // formdan gelecek elemanları ekleyecek bir yapı oluşturduk
        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
            // burada bir if else yapılabilir kullanıcı varsa ekle veya ekleme gibi
            // veya bu durumu controller ile de yapabiliriz
        }
    }
}