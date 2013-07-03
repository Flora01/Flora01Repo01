namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InviteCodes : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201112092057338_InviteCodes"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
