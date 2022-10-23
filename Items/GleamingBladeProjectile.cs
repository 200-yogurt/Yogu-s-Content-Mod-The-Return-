using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Metrics;

namespace YogusContentMod.Items
{
    internal class GleamingBladeProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Main.projFrames[Type] = 1; // 1 frame
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
        }

        Player Owner => Main.player[Projectile.owner];

        public override void AI()
        {
            base.AI();
            Projectile.Center = Owner.itemLocation;
            float targetRotation = Owner.itemRotation + Owner.fullRotation;
            Projectile.rotation = MathHelper.Lerp(targetRotation - MathHelper.PiOver2, targetRotation + MathHelper.PiOver2, Owner.itemAnimation / (float)Owner.itemAnimationMax);
        }

        public override bool PreDraw(ref Color lightColor)
        {
            return base.PreDraw(ref lightColor);
        }

        public override void PostDraw(Color lightColor)
        {
            base.PostDraw(lightColor);
        }
    }
}
