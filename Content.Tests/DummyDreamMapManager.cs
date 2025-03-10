﻿using System.Collections.Generic;
using OpenDreamRuntime;
using OpenDreamRuntime.Objects;
using OpenDreamRuntime.Procs;
using OpenDreamShared.Dream;
using OpenDreamShared.Json;
using Robust.Shared.Maths;

namespace Content.Tests {
    public sealed class DummyDreamMapManager : IDreamMapManager {
        public Vector2i Size => Vector2i.Zero;
        public int Levels => 0;

        public void Initialize() { }

        public void UpdateTiles() { }

        public void LoadMaps(List<DreamMapJson> maps) { }

        public void SetTurf(DreamObject turf, DreamObjectDefinition type, DreamProcArguments creationArguments) { }

        public void SetTurfAppearance(DreamObject turf, IconAppearance appearance) { }

        public IconAppearance GetTurfAppearance(DreamObject turf) {
            return new IconAppearance();
        }

        public bool TryGetTurfAt(Vector2i pos, int z, out DreamObject turf) {
            turf = null;
            return false;
        }

        public (Vector2i Pos, DreamMapManager.Level Level) GetTurfPosition(DreamObject turf) {
            return (Vector2i.Zero, null);
        }

        public DreamObject GetAreaAt(DreamObject turf) {
            return null;
        }

        public void SetZLevels(int levels) { }
    }
}
