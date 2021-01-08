<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/SellBa.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/order/SellBa.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Order_Id',
                    footer: "Foots",
                    cnName: '订单配置',
                    name: 'SellBa',
                    url: "/SellBa/",
                    sortName: "Order_Id"
                },
                extend: extend,
                editFormFields: {"OrderType":"","TranNo":"","SellNo":"","Qty":"","AuditDate":"","AuditStatus":"","Auditor":"","Remark":""},
                editFormOptions: [[{"dataKey":"ordertype","data":[],"title":"订单类型","required":true,"field":"OrderType","type":"select"},
                               {"title":"运单号","required":true,"field":"TranNo","type":"text"},
                               {"title":"销售单号","required":true,"field":"SellNo","type":"text"}],
                              [{"title":"数量","required":true,"field":"Qty","type":"text"},
                               {"title":"审核日期","field":"AuditDate","type":"date"},
                               {"dataKey":"restatus","data":[],"title":"审核状态","required":true,"field":"AuditStatus","type":"select"}],
                              [{"title":"审核人","field":"Auditor","type":"text"},
                               {"title":"备注","field":"Remark","type":"textarea"}]],
                searchFormFields: {"Order_Id":"","OrderType":"","TranNo":"","SellNo":"","Qty":"","AuditDate":"","AuditStatus":"","AuditId":"","Auditor":"","Remark":""},
                searchFormOptions: [[{"title":"订单Id","field":"Order_Id","type":"text"},{"dataKey":"ordertype","data":[],"title":"订单类型","field":"OrderType","type":"select"},{"title":"运单号","field":"TranNo","type":"text"}],[{"title":"销售单号","field":"SellNo","type":"text"},{"title":"数量","field":"Qty","type":"text"},{"dataKey":"restatus","data":[],"title":"审核状态","field":"AuditStatus","type":"select"}],[{"title":"审核日期","field":"AuditDate","type":"date"},{"title":"审核人Id","field":"AuditId","type":"number"},{"title":"审核人","field":"Auditor","type":"text"}],[{"title":"备注","field":"Remark","type":"textarea"}]],
                columns: [{field:'Order_Id',title:'订单Id',type:'guid',width:90,readonly:true,require:true,align:'left',sortable:true},
                       {field:'OrderType',title:'订单类型',type:'int',bind:{ key:'ordertype',data:[]},width:90,require:true,align:'left'},
                       {field:'TranNo',title:'运单号',type:'string',width:180,require:true,align:'left'},
                       {field:'SellNo',title:'销售单号',type:'string',width:220,require:true,align:'left'},
                       {field:'Qty',title:'数量',type:'int',width:90,require:true,align:'left'},
                       {field:'AuditDate',title:'审核日期',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'AuditStatus',title:'审核状态',type:'int',bind:{ key:'restatus',data:[]},width:90,require:true,align:'left'},
                       {field:'AuditId',title:'审核人Id',type:'int',width:90,align:'left'},
                       {field:'Auditor',title:'审核人',type:'string',width:180,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,hidden:true,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,hidden:true,align:'left',sortable:true}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
