using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Domain
{
    public class MovieReview
    {
        public string Content { get; set; }
        public string Reviewer { get; set; }
        public string Publication { get; set; }

        public MovieReview(Guid reviewId, string contentm, string reviewer, string publication)
        {
            //Implementation done in Step 6
        }

    }
}
