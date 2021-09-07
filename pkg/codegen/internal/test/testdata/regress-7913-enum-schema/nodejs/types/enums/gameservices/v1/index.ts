// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const CloudAuditOptionsLogName = {
    /**
     * Default. Should not be used.
     */
    UnspecifiedLogName: "UNSPECIFIED_LOG_NAME",
    /**
     * Corresponds to "cloudaudit.googleapis.com/activity"
     */
    AdminActivity: "ADMIN_ACTIVITY",
    /**
     * Corresponds to "cloudaudit.googleapis.com/data_access"
     */
    DataAccess: "DATA_ACCESS",
    /**
     * What if triple quotes """ are used in the description
     */
    Synthetic: "SYNTHETIC",
} as const;

/**
 * The log_name to populate in the Cloud Audit Record.
 */
export type CloudAuditOptionsLogName = (typeof CloudAuditOptionsLogName)[keyof typeof CloudAuditOptionsLogName];
