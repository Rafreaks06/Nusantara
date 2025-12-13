using Nusantara.Models;

namespace Nusantara.Forms
{
    internal class ProfilePage : Control
    {
        private Member loggedMember;

        public ProfilePage(Member loggedMember)
        {
            this.loggedMember = loggedMember;
        }
    }
}