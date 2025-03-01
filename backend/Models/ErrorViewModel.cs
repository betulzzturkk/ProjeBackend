using System;

namespace backend.Models
{
    public class ErrorViewModel
    {
        // İstekle ilgili benzersiz ID
        public string RequestId { get; set; }

        // RequestId'nin null veya boş olup olmadığını kontrol eden bir özellik
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
