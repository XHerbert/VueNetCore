<!--
 *Author：xuhbd
 *Contact：xuhb-c@glodon.coms
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/business/House.js此处编写
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
    import extend from "@/extension/business/House.js";
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
                    cnName: '房屋管理',
                    name: 'House',
                    url: "/House/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFields: {"HouseNumber":"","Area":"","BelongUnit":"","HouseAddress":"","HouseStatus":"","RentFee":"","HouseType":"","EnableFlag":""},
                editFormOptions: [[{"title":"房号","field":"HouseNumber","type":"text"}],
                              [{"title":"房屋面积(平米)","field":"Area","type":"decimal"}],
                              [{"dataKey":"houseUnit","data":[],"title":"所属单位","field":"BelongUnit","type":"select"}],
                              [{"title":"地址","field":"HouseAddress","type":"textarea"}],
                              [{"dataKey":"houseStatus","data":[],"title":"房屋状态","field":"HouseStatus","type":"select"}],
                              [{"title":"房屋租金(元)","field":"RentFee","type":"decimal"}],
                              [{"dataKey":"houseType","data":[],"title":"房屋类别","field":"HouseType","type":"select"}],
                              [{"dataKey":"enable","data":[],"title":"是否启用","field":"EnableFlag","type":"select"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'序号',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'HouseCode',title:'房屋编码',type:'string',link:true,width:90,align:'left',sortable:true},
                       {field:'HouseNumber',title:'房号',type:'string',width:120,align:'left'},
                       {field:'Area',title:'房屋面积(平米)',type:'decimal',width:90,align:'left'},
                       {field:'BelongUnit',title:'所属单位',type:'int',bind:{ key:'houseUnit',data:[]},width:90,align:'left'},
                       {field:'HouseAddress',title:'地址',type:'string',width:180,align:'left'},
                       {field:'HouseType',title:'房屋类别',type:'int',bind:{ key:'houseType',data:[]},width:120,align:'left'},
                       {field:'HouseStatus',title:'房屋状态',type:'int',bind:{ key:'houseStatus',data:[]},width:90,align:'left'},
                       {field:'RentFee',title:'房屋租金(元)',type:'decimal',width:90,align:'left'},
                       {field:'EnableFlag',title:'是否启用',type:'int',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,require:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true}],
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
