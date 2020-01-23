using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG2Connector
{
    public class StockItem
    {

        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemId { get; set; }

        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        [JsonProperty("stock_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StockId { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public int Qty { get; set; }

        [JsonProperty("is_in_stock", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsInStock { get; set; }

        [JsonProperty("is_qty_decimal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQtyDecimal { get; set; }

        [JsonProperty("show_default_notification_message", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDefaultNotificationMessage { get; set; }

        [JsonProperty("use_config_min_qty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigMinQty { get; set; }

        [JsonProperty("min_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinQty { get; set; }

        [JsonProperty("use_config_min_sale_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseConfigMinSaleQty { get; set; }

        [JsonProperty("min_sale_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinSaleQty { get; set; }

        [JsonProperty("use_config_max_sale_qty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigMaxSaleQty { get; set; }

        [JsonProperty("max_sale_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSaleQty { get; set; }

        [JsonProperty("use_config_backorders", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigBackorders { get; set; }

        [JsonProperty("backorders", NullValueHandling = NullValueHandling.Ignore)]
        public int? Backorders { get; set; }

        [JsonProperty("use_config_notify_stock_qty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigNotifyStockQty { get; set; }

        [JsonProperty("notify_stock_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotifyStockQty { get; set; }

        [JsonProperty("use_config_qty_increments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigQtyIncrements { get; set; }

        [JsonProperty("qty_increments", NullValueHandling = NullValueHandling.Ignore)]
        public int? QtyIncrements { get; set; }

        [JsonProperty("use_config_enable_qty_inc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigEnableQtyInc { get; set; }

        [JsonProperty("enable_qty_increments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQtyIncrements { get; set; }

        [JsonProperty("use_config_manage_stock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseConfigManageStock { get; set; }

        [JsonProperty("manage_stock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManageStock { get; set; }

        [JsonProperty("low_stock_date", NullValueHandling = NullValueHandling.Ignore)]
        public object LowStockDate { get; set; }

        [JsonProperty("is_decimal_divided", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDecimalDivided { get; set; }

        [JsonProperty("stock_status_changed_auto", NullValueHandling = NullValueHandling.Ignore)]
        public int? StockStatusChangedAuto { get; set; }
    }

    public class ExtensionAttributes
    {

        [JsonProperty("stock_item")]
        public StockItem StockItem { get; set; }
    }

    public class CustomAttribute
    {

        [JsonProperty("attribute_code")]
        public string AttributeCode { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }

    public class M2Product
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attribute_set_id")]
        public int AttributeSetId { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("extension_attributes")]
        public ExtensionAttributes ExtensionAttributes { get; set; }

        [JsonProperty("product_links")]
        public IList<object> ProductLinks { get; set; }

        [JsonProperty("options")]
        public IList<object> Options { get; set; }

        [JsonProperty("media_gallery_entries")]
        public IList<object> MediaGalleryEntries { get; set; }

        [JsonProperty("tier_prices")]
        public IList<object> TierPrices { get; set; }

        [JsonProperty("custom_attributes")]
        public IList<CustomAttribute> CustomAttributes { get; set; }
    }

    public class SkuUpdate
    {
        [JsonProperty("stockItem")]
        public StockItem StockItem { get; set; }
    }
}
