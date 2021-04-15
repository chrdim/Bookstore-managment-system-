using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
   
        [MetadataType(typeof(AuthorMetadata))]
        public partial class author
        {

        }
        [MetadataType(typeof(TitleauthorMetadata))]
        public partial class titleauthor
        {

        }

        [MetadataType(typeof(TitleMetadata))]
        public partial class title
        {

        }

        [MetadataType(typeof(PublisherMetadata))]
        public partial class publisher
        {

        }

        [MetadataType(typeof(DiscountMetadata))]
        public partial class discount
        {

        }

        [MetadataType(typeof(EmployeeMetadata))]
        public partial class employee
        {

        }

        [MetadataType(typeof(StoreMetadata))]
        public partial class store
        {

        }

        [MetadataType(typeof(JobMetadata))]
        public partial class job
        {

        }

        [MetadataType(typeof(SaleMetadata))]
        public partial class sale
        {

        }
    }
