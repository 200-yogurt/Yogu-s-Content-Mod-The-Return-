using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace YogusContentMod.Items
{
    internal class GleamingBladeSlash : ModProjectile 
    {
        public override string Texture => "YogusContentMod/Animations/Slashes/StarSlashSheet";

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Main.projFrames[Type] = 8;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            SetStaticDefaults();
            var size = ModContent.Request<Texture2D>(Texture).Value.Size(); // TODO: wip
            Projectile.width = (int)size.X;
            Projectile.height = (int)size.Y / Main.projFrames[Type];
            Projectile.timeLeft = 20;
            Projectile.scale = 1.5f;
            Projectile.tileCollide = false;
        }

        public override void AI()
        {
            base.AI();
            var owner = Main.player[Projectile.owner];
            Projectile.frame = (int)MathHelper.Lerp(7, 1, owner.itemAnimation / (float)owner.itemAnimationMax);
            Projectile.position = owner.position - Projectile.Size * Projectile.scale / 2;
            Projectile.direction = owner.direction;
            Projectile.spriteDirection = owner.direction;
        }


        public override bool PreDraw(ref Color lightColor)
        {
            return base.PreDraw(ref lightColor);
        }

    }
}
