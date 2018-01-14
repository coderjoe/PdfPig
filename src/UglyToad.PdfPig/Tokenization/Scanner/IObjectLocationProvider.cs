﻿namespace UglyToad.PdfPig.Tokenization.Scanner
{
    using System.Collections.Generic;
    using ContentStream;
    using Cos;
    using Parser.Parts;

    internal interface IObjectLocationProvider
    {
        bool TryGetOffset(IndirectReference reference, out long offset);

        void UpdateOffset(IndirectReference reference, long offset);
    }

    internal class ObjectLocationProvider : IObjectLocationProvider
    {
        private readonly CrossReferenceTable crossReferenceTable;
        private readonly CosObjectPool pool;
        private readonly BruteForceSearcher searcher;

        private readonly Dictionary<IndirectReference, long> offsets = new Dictionary<IndirectReference, long>();

        public ObjectLocationProvider(CrossReferenceTable crossReferenceTable, CosObjectPool pool, BruteForceSearcher searcher)
        {
            this.crossReferenceTable = crossReferenceTable;
            this.pool = pool;
            this.searcher = searcher;
        }

        public bool TryGetOffset(IndirectReference reference, out long offset)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOffset(IndirectReference reference, long offset)
        {
            throw new System.NotImplementedException();
        }
    }
}