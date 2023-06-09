//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowerShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flower
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flower()
        {
            this.ListAdminOrder = new HashSet<ListAdminOrder>();
            this.ListClientOrder = new HashSet<ListClientOrder>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> Markup { get; set; }
        public byte[] Img { get; set; }
    
        public virtual Provider Provider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListAdminOrder> ListAdminOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListClientOrder> ListClientOrder { get; set; }
    }
}
