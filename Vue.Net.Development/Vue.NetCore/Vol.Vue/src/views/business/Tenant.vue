<!--
 *Author：xuhbd
 *Contact：xuhb-c@glodon.coms
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/Tenant.js此处编写
 -->
<template>
    <div>
        <view-grid ref="grid"
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
    import extend from "@/extension/business/Tenant.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Id',
                    footer: "Foots",
                    cnName: '租客管理',
                    name: 'Tenant',
                    url: "/Tenant/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"TenantName":"","Gender":"","BelongUnit":"","Mobile":"","IdCard":"","EnableFlag":"","Address":""},
                editFormOptions: [[{"title":"姓名","field":"TenantName","type":"text"},
                               {"dataKey":"gender","data":[],"title":"性别","field":"Gender","colSize":3,"type":"select"},
                               {"dataKey":"houseUnit","data":[],"title":"所属单位","field":"BelongUnit","type":"select"}],
                              [{"title":"手机号","field":"Mobile","type":"text"},
                               {"title":"身份证","field":"IdCard","type":"text"},
                               {"dataKey":"enable","data":[],"title":"是否有效","field":"EnableFlag","colSize":3,"type":"switch"}],
                              [{"title":"详细地址","field":"Address","colSize":6,"type":"textarea"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'序号',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'TenantCode',title:'编码',type:'string',link:true,width:90,align:'left',sortable:true},
                       {field:'TenantName',title:'姓名',type:'string',width:90,align:'left'},
                       {field:'Gender',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:90,align:'left'},
                       {field:'Mobile',title:'手机号',type:'string',width:90,align:'left'},
                       {field:'IdCard',title:'身份证',type:'string',width:90,align:'left'},
                       {field:'Address',title:'详细地址',type:'string',width:220,align:'left'},
                       {field:'EnableFlag',title:'是否有效',type:'int',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,require:true,align:'left'},
                       {field:'CreateDate',title:'创建日期',type:'datetime',width:90,align:'left',sortable:true}],
                detail: {
                    cnName: "#detailCnName",
                    columns: [],
                    sortName: "",
                    key: ""
                }
            };
        }
    };
    export default vueParam;
</script>
