using System.Numerics;

namespace AltV.Net.EntitySync
{
    /// <summary>
    /// A client is a connected peer that authenticated itself via a token.
    /// In most cases the client contains a IPlayer object and gets the position and exists status out of this.
    /// </summary>
    public class Client : IClient
    {
        public string Token { get; }

        public virtual Vector3 Position { get; set; }

        public virtual int Dimension { get; set; }

        public ClientDataSnapshot Snapshot { get; } = new ClientDataSnapshot();

        public virtual bool Exists { get; } = true;

        private Vector3 positionOverride;

        private bool isPositionOverwritten;

        public Client(string token)
        {
            Token = token;
        }

        public virtual bool TryGetPosition(out Vector3 position)
        {
            lock (this)
            {
                if (isPositionOverwritten)
                {
                    position = positionOverride;
                }
                else
                {
                    position = Position;
                }
            }

            return true;
        }

        public virtual bool TryGetDimension(out int dimension)
        {
            dimension = Dimension;
            return true;
        }

        public void SetPositionOverride(Vector3 newPositionOverride)
        {
            lock (this)
            {
                positionOverride = newPositionOverride;
                isPositionOverwritten = true;
            }
        }

        public void ResetPositionOverride()
        {
            lock (this)
            {
                isPositionOverwritten = false;
            }
        }
    }
}