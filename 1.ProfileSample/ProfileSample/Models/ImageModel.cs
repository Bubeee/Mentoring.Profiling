namespace ProfileSample.Models
{
    public class ImageModel
    {
        public ImageModel()
        {
            
        }

        public ImageModel(string name, byte[] data)
        {
            Name = name;
            Data = data;
        }

        public string Name { get; set; }

        public byte[] Data { get; set; } 
    }
}