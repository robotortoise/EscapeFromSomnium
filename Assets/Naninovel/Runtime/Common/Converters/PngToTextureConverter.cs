using UnityEngine;

namespace Naninovel
{
    /// <summary>
    /// Converts <see cref="T:byte[]"/> raw data of a .png image to <see cref="Texture2D"/>.
    /// </summary>
    public class PngToTextureConverter : IRawConverter<Texture2D>
    {
        public RawDataRepresentation[] Representations { get; } = {
            new RawDataRepresentation(".png", "image/png")
        };

        public Texture2D Convert (byte[] obj, string name)
        {
            var texture = new Texture2D(2, 2);
            texture.name = name;
            texture.LoadImage(obj, true);
            return texture;
        }

        public UniTask<Texture2D> ConvertAsync (byte[] obj, string name) => UniTask.FromResult(Convert(obj, name));

        public object Convert (object obj, string name) => Convert(obj as byte[], name);

        public async UniTask<object> ConvertAsync (object obj, string name) => await ConvertAsync(obj as byte[], name);
    }
}
